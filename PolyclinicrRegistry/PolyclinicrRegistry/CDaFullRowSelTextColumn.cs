using System;
using System.Drawing;
using System.Windows.Forms;
using AdyLibTextColumn;


namespace AdyLibTextColumn
{
    /// <summary>
    /// Summary description for FullRowSelectionTextColumn.
    /// </summary>
    public class CAdyFullRowSelTextColumn : DataGridTextBoxColumn
    {

        private System.Drawing.Color mBackColor;
        protected HorizontalAlignment align = HorizontalAlignment.Left;
        /// <summary>
        /// �������� ������������� ���������
        /// </summary>
        protected string headerText = "";
        /// <summary>
        /// �������� ������������� ��������
        /// </summary>
        protected string nullText = "";
        private Graphics gr = null;
        private Font font = null;


        public CAdyFullRowSelTextColumn(Control control, Font font) : base()
        {
            if (control != null)
            {
                gr = control.CreateGraphics();
            }

            if (font != null)
            {
                this.font = font;
            }
        }

        public CAdyFullRowSelTextColumn()
        {

        }

        /// <summary>
        /// ����������� ��������� �� ������ ����� ���������
        /// </summary>
        public override string HeaderText
        {
            get => base.HeaderText;
            set
            {
                if (value != null)
                {
                    headerText = value.Trim();
                    base.HeaderText = CenterText(headerText, Width);
                }
            }
        }

        /// <summary>
        /// ������ �������
        /// </summary>
        /// <remarks>��� ��������� �������� ����������� �������������</remarks>
        public override int Width
        {
            get => base.Width;
            set
            {
                base.Width = value;
                base.HeaderText = CenterText(headerText, Width);
                base.NullText = CenterText(nullText, Width);
            }
        }

        /// <summary>
        /// ������������ ������
        /// </summary>
        /// <param name="Text">�������� ������</param>
        /// <param name="Width">������ �������</param>
        /// <returns>������, ����������� ������� ���������</returns>
        private string CenterText(string Text, int Width)
        {
            if (gr == null &&
                DataGridTableStyle != null &&
                DataGridTableStyle.DataGrid != null)
            {
                gr = DataGridTableStyle.DataGrid.CreateGraphics();
            }

            if (font == null &&
                DataGridTableStyle != null)
            {
                font = DataGridTableStyle.HeaderFont;
            }

            if (gr == null || font == null)
            {
                return Text;
            }

            string text = Text;
            int textw = (int)gr.MeasureString(text, font).Width;
            int blankw = (this.Width - textw) / 2;
            int nblank = Math.Max(0, blankw / (int)Math.Max(gr.MeasureString(" ", font).Width, 1));
            if (align != HorizontalAlignment.Center)
            {
                return new string(' ', nblank) + text;
            }
            else
            {
                return text;
            }
        }

        /// <summary>
        /// ������������ ������� �� ������� ������������
        /// </summary>
        /// <remarks>������ ������������ ������ �������,
        /// ������ ����� ���������.
        /// </remarks>
        public override HorizontalAlignment Alignment
        {
            get => base.Alignment;
            set
            {
                if (value == HorizontalAlignment.Right)
                {
                    base.Alignment = HorizontalAlignment.Left;
                }
                else
                {
                    base.Alignment = value;
                }

                align = value;


            }
        }


        // �������� ����������� ������� ����� 
        public System.Drawing.Color ColorBackSelect
        {
            set => mBackColor = value;
        }

        // ���� �� ��������� ��������������, � �� ����������� �������� readonly ������� ����� �.
        protected override void Edit(
            CurrencyManager source, int rowNum,
            Rectangle bounds, bool readOnly, string instantText, bool cellIsVisible)
        {
            Abort(rowNum);
        }


        protected override void Paint(
            Graphics g, Rectangle bounds, CurrencyManager source, int rowNum,
            Brush backBrush, Brush foreBrush, bool alignToRight)
        {


            if (source.Position == rowNum)
            {
                backBrush = new SolidBrush(mBackColor);
                foreBrush = new SolidBrush(SystemColors.ActiveCaptionText);
                //backBrush = new SolidBrush(SystemColors.ActiveCaption);
                //foreBrush = new SolidBrush(SystemColors.ActiveCaptionText);
            }

            bool AlignToRight = (align == HorizontalAlignment.Right);
            if (AlignToRight)
            {
                base.Paint(g, bounds, source, rowNum, backBrush, foreBrush, AlignToRight);
            }
            else
            {
                base.Paint(g, bounds, source, rowNum, backBrush, foreBrush, alignToRight);
            }
        }




    }

}
