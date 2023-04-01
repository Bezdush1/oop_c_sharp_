using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsUI
{
    public partial class ObjectsManipulatorWindow : Form
    {
        private LibraryDictionary _libraryDictionary = new LibraryDictionary();

        public ObjectsManipulatorWindow()
        {
            InitializeComponent();

            _libraryDictionary.OnAdditionChange += _libraryDictionary_OnAdditionChange;
            _libraryDictionary.OnRemovalChange += _libraryDictionary_OnRemovalChange;
        }

        private void _libraryDictionary_OnRemovalChange(object? sender, int e)
        {
            for (int i = 0; i < objsTable.RowCount - 1; i++)
            {
                if ((int)objsTable.Rows[i].Cells[0].Value == e)
                {
                    objsTable.Rows.RemoveAt(i);
                }
            }

            objsTable.Refresh();
            Utils.FillOutputLog($"Объект с ID {e} был успешно удален", outputLog, " ");
        }

        private void _libraryDictionary_OnAdditionChange(object? sender, Library e)
        {
            int index = objsTable.Rows.Add();
            objsTable.Rows[index].Cells[0].Value = _libraryDictionary.CurrentID;
            objsTable.Rows[index].Cells[1].Value = e.Name;
            objsTable.Rows[index].Cells[2].Value = e.Description;
            objsTable.Rows[index].Cells[3].Value = e.Type;
            objsTable.Rows[index].Cells[4].Value = e.BooksNumber;
            objsTable.Rows[index].Cells[5].Value = e.ReadingRoomsCount;
            objsTable.Rows[index].Cells[6].Value = e.Rating;
            objsTable.Rows[index].Cells[7].Value = e.WithWiFi ? "Да" : "Нет";
            objsTable.Refresh();
            Utils.FillOutputLog($"Объект был успешно создан", outputLog, " ");
        }

        private void changePropertyButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(changePropertyID.Text, out int key))
            {
                if (_libraryDictionary.ContainsID(key))
                {
                    Library? library = _libraryDictionary.GetLibrary(key);
                    try
                    {
                        library?.TryChangeProperty(changePropertyName.Text, changePropertyValue.Text);
                        Utils.FillOutputLog("Объект изменен успешно", outputLog);
                    }
                    catch (Exception ex)
                    {
                        Utils.MessageBox(IntPtr.Zero, ex.Message, "Ошибка", 0);
                    }
                }
                else
                {
                    Utils.MessageBox(IntPtr.Zero, "Такого ID не существует", "Ошибка", 0);
                }
            }
            else
            {
                Utils.MessageBox(IntPtr.Zero, "Неправильный тип ключа", "Ошибка", 0);
            }
        }

        private void printPropertyButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(printPropertyID.Text, out int key))
            {
                if (_libraryDictionary.ContainsID(key))
                {
                    Library? library = _libraryDictionary.GetLibrary(key);
                    if (inHexCheckBox.Checked)
                    {
                        try
                        {
                            Utils.FillOutputLog(library?.GetPropertyInHexMessage(printPropertyName.Text), printPropertyName);
                        }
                        catch (Exception ex)
                        {
                            Utils.MessageBox(IntPtr.Zero, ex.Message, "Ошибка", 0);
                        }
                    }
                    else
                    {
                        try
                        {
                            Utils.FillOutputLog(library?.GetPropertyMessage(printPropertyName.Text), printPropertyName);
                        }
                        catch (Exception ex)
                        {
                            Utils.MessageBox(IntPtr.Zero, ex.Message, "Ошибка", 0);
                        }
                    }
                }
                else
                {
                    Utils.MessageBox(IntPtr.Zero, "Такого ID не существует", "Ошибка", 0);
                }
            }
            else
            {
                Utils.MessageBox(IntPtr.Zero, "Неправильный тип ключа", "Ошибка", 0);
            }
        }

        private void createObjButton_Click(object sender, EventArgs e)
        {
            string name = newObjName.Text == "" ? "Безымянная" : newObjName.Text;
            string description = newObjDescription.Text;
            string type = newObjType.Text == "" ? "Обычная" : newObjType.Text;
            decimal rating = newObjRating.Value;
            long booksNumber = (long)newObjBooksNumber.Value;
            int readingRooms = (int)newObjReadingRooms.Value;

            Library library = new Library(name, description, booksNumber, readingRooms, type, withWiFiCheckBox.Checked, rating);
            _libraryDictionary.Add(library);
        }

        private void deleteObjButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(deleteObjID.Text, out int key))
            {
                if (!_libraryDictionary.Remove(key))
                {
                    Utils.MessageBox(IntPtr.Zero, "Такого ID не существует", "Ошибка", 0);
                }
            }
            else
            {
                Utils.MessageBox(IntPtr.Zero, "Неправильный тип ключа", "Ошибка", 0);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clearLogButton_Click(object sender, EventArgs e)
        {
            outputLog.Clear();
        }

        private void printObjsAsString_Click(object sender, EventArgs e)
        {
            string[] objsStrings = new string[_libraryDictionary.Size()];
            int i = 0;
            foreach (Library item in _libraryDictionary)
            {
                objsStrings[i++] = item.ToString();
            }
            objsStrings.Select(str => str.Trim());
            Utils.FillOutputLog(objsStrings, outputLog, "++++++++++++++++++++++++");
        }
    }
}
