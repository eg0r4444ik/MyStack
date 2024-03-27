using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyStack
{
    public partial class MainWindow : Window
    {
        private MyStack<int> myStack;

        public MainWindow()
        {
            InitializeComponent();
            myStack = new MyStack<int>();
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            txtCurrentElement.Text = myStack.IsEmpty ? "N/A" : myStack.CurrentElement.ToString();
            txtCount.Text = myStack.Count.ToString();
            txtIsEmpty.Text = myStack.IsEmpty.ToString();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            int newItem;
            if (int.TryParse(txtInput.Text, out newItem))
            {
                myStack.Add(newItem);
                UpdateDisplay();
            }
            else
            {
                MessageBox.Show("Введите корректное число типа integer");
            }
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                myStack.Remove();
                UpdateDisplay();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            myStack.Clear();
            UpdateDisplay();
        }
    }
}
