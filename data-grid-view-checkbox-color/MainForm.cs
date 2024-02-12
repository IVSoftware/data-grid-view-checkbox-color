
using System.ComponentModel;
using System.Drawing.Text;

namespace data_grid_view_checkbox_color
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Disposed += (sender, e) => Provider.Dispose();
        }
        FontFamily CheckBoxFont { get; } = "checkbox-icons".LoadFamilyFromEmbeddedFont();
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            {
                dataGridView.DataSource = Recordset;
                dataGridView.RowHeadersVisible = false;
                dataGridView.AllowUserToAddRows = false;
                dataGridView.CellPainting += (sender, e) =>
                {
                    if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataGridView[e.ColumnIndex, e.RowIndex] is DataGridViewCheckBoxCell checkbox)
                    {
                        if (dataGridView[e.ColumnIndex, e.RowIndex].IsInEditMode == true)
                        {
                            dataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
                        }
                        e.Handled = true;
                        e.PaintBackground(e.CellBounds, false);
                        using (var glyphFont = new Font(CheckBoxFont, dataGridView.DefaultCellStyle.Font.Size + 1))
                        using (var sf = new StringFormat
                        {
                            Alignment = StringAlignment.Center,
                            LineAlignment = StringAlignment.Center,
                        })
                        {
                            Brush brush;   
                            switch (dataGridView.Columns[e.ColumnIndex].Name)
                            { 
                                // Use a static brush (doesn't require dispose)
                                case nameof(DemoRecordClass.IsGreen): brush = Brushes.Green; break;
                                case nameof(DemoRecordClass.IsBlue): brush = Brushes.Blue; break;
                                case nameof(DemoRecordClass.IsRed): brush = Brushes.Red; break;
                                default:
                                    return;
                            }
                            var glyph = e.Value is bool isChecked && isChecked ? "\uE801" : "\uE800";
                            e.Graphics?.DrawString(glyph, glyphFont, brush, e.CellBounds, sf);
                        }
                    }
                };
                foreach (DataGridViewColumn col in dataGridView.Columns)
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                Recordset.Add(new DemoRecordClass{ IsGreen = true, IsRed = true, });
                Recordset.Add(new DemoRecordClass{ IsBlue= true, });
            }
        }
        BindingList<DemoRecordClass> Recordset { get; } = new BindingList<DemoRecordClass>();
    }

    class DemoRecordClass
    {
        static int count = 1;
        public string Name { get; set; } = $"Item {count++}";
        public bool IsGreen { get;set; }
        public bool IsBlue { get;set; }
        public bool IsRed { get;set; }
    }
    public static class Provider
    {
        public static FontFamily LoadFamilyFromEmbeddedFont(this string ttf)
        {
            var asm = typeof(Provider).Assembly;
#if DEBUG
            var names = asm.GetManifestResourceNames();
            { }
#endif
            var fontFamily = privateFontCollection.Families.FirstOrDefault(_ => _.Name.Equals(ttf));
            if (fontFamily == null)
            {
                var resourceName = asm.GetManifestResourceNames().FirstOrDefault(_ => _.Contains(ttf));
                if (string.IsNullOrWhiteSpace(resourceName))
                {
                    throw new InvalidOperationException("Expecting font file is embedded resource.");
                }
                else
                {
                    // Get the embedded font resource stream
                    using (Stream fontStream = asm.GetManifestResourceStream(resourceName)!)
                    {
                        if (fontStream == null)
                        {
                            throw new InvalidOperationException($"Font resource '{resourceName}' not found.");
                        }
                        else
                        {
                            // Load the font into the PrivateFontCollection
                            byte[] fontData = new byte[fontStream.Length];
                            fontStream.Read(fontData, 0, (int)fontStream.Length);

                            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
                            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
                            privateFontCollection.AddMemoryFont(fontPtr, fontData.Length);

                            fontFamily = privateFontCollection.Families.First(_ => _.Name.Equals(ttf));
                        }
                    }
                }
            }
            else
            {   /* G T K */
                // Already loaded
            }
            return fontFamily;
        }
        public static void Dispose() => privateFontCollection?.Dispose();
        private static PrivateFontCollection privateFontCollection { get; } = new PrivateFontCollection();
    }
}
