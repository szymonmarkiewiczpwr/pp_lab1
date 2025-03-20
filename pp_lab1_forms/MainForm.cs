using pp_lab1;

namespace pp_lab1_forms
{
    public partial class MainForm : Form
    {
        private Problem? _problem;

        private ErrorProvider _errorProvider = new ErrorProvider();

        private List<BackpackItem> _generatedItemsList = new List<BackpackItem>();
        private List<BackpackItem> _backpackItemsList = new List<BackpackItem>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void performSolveButton_Click(object sender, EventArgs e)
        {
            if (_errorProvider.HasErrors)
                return;

            if (overrideItemsAmount.Checked)
                _problem = new Problem(int.Parse(rngStateInput.Text), int.Parse(itemsAmountInput.Text));
            else
                _problem = new Problem(int.Parse(rngStateInput.Text));

            _generatedItemsList = _problem.AvaiableItems;
            _backpackItemsList = _problem.Solve(int.Parse(backpackCapacityInput.Text));

            UpdateItemsLists();
        }

        private void UpdateItemsLists()
        {
            foreach (BackpackItem item in _generatedItemsList)
            {
                generatedItemsList.Items.Add(item.ToString());
            }

            foreach (BackpackItem item in _backpackItemsList)
            {
                resultsItemList.Items.Add(item.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rngStateInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void rngStateInput_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!int.TryParse(rngStateInput.Text, out int _))
            {
                e.Cancel = true;
                _errorProvider.SetError(rngStateInput, "Must be a valid integer");
                return;
            }

            _errorProvider.Clear();
        }

        private void itemsAmountInput_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!int.TryParse(itemsAmountInput.Text, out int _))
            {
                e.Cancel = true;
                _errorProvider.SetError(itemsAmountInput, "Must be a valid integer");
                return;
            }

            _errorProvider.Clear();
        }

        private void backpackCapacityInput_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!int.TryParse(backpackCapacityInput.Text, out int _))
            {
                e.Cancel = true;
                _errorProvider.SetError(backpackCapacityInput, "Must be a valid integer");
                return;
            }

            _errorProvider.Clear();
        }

        private void overrideItemsAmount_CheckedChanged(object sender, EventArgs e)
        {
            itemsAmountInput.Enabled = overrideItemsAmount.Checked;
        }

        private void resultsItemList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
