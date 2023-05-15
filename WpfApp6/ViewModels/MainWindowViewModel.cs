using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp6.Models;

namespace WpfApp6.ViewModels
{
    internal class MainWindowViewModel : Base.ViewModel
    {
        public MainWindowViewModel() { Size = "3"; }

        DataTable field;
        public DataTable Field
        {
            get => field;
            set => Set(ref field, value);
            
        }

        int size = 3;
        public string Size
        {
            get => size.ToString();
            set 
            {
                if (int.TryParse(value, out int newSize))
                {
                    Set(ref size, newSize);
                    DataTable newField = new DataTable();
                    for (int i = 0; i < newSize; i++)
                        newField.Columns.Add();
                    
                    for (int i = 0; i < newSize; i++)
                    {
                        object[] row = new object[newSize];
                        for (int j = 0; j < size; j++)
                            row[j] = i * 10 + j;
                        newField.Rows.Add(row);
                    }
                    Field = newField;
                }
            }
        }

    }
}
