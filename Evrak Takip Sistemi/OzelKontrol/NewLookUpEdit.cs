namespace ETS.OzelKontrol
{
    using System.Windows.Forms;
    using DevExpress.XtraEditors;

    public class BetsLookUpEdit : LookUpEdit
    {
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (SelectionLength != Text.Length || (e.KeyData != Keys.Back && e.KeyData != Keys.Delete)) return;            
            EditValue = null;
            e.Handled = true;
        }
    }
}
