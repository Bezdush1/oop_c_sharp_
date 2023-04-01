using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformsUI
{
    public class LibraryDictionary : IEnumerable
    {
        /// <summary>
        /// Поле нового ключа для следующего элемента
        /// </summary>
        private int _newId;
        /// <summary>
        /// Коллекция с объектами класса Library
        /// </summary>
        private Dictionary<int, Library> _libraryDictionary = new Dictionary<int, Library>();
        /// <summary>
        /// Событие при добавлении элемента из коллекции
        /// </summary>
        public event AdditionEvent OnAdditionChange;
        /// <summary>
        /// Событие при удалении элемента из коллекции
        /// </summary>
        public event RemoveitionEvent OnRemovalChange;
        /// <summary>
        /// Свойство текущего ключа
        /// </summary>
        public int CurrentID { get { return _newId; } }

        /// <summary>
        /// Делегат для события добавления
        /// </summary>
        /// <param name="sender">Откуда был вызван</param>
        /// <param name="library">Объект класса Library</param>
        public delegate void AdditionEvent(object sender, Library library);
        /// <summary>
        /// Делегат для события удаления
        /// </summary>
        /// <param name="sender">Откуда был вызван</param>
        /// <param name="id">Целочисленное число - айди</param>
        public delegate void RemoveitionEvent(object sender, int id);

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public LibraryDictionary()
        {
            _newId = 0;
        }

        /// <summary>
        /// Добавляет в коллекцию объект класса Library
        /// </summary>
        /// <param name="library">Объект класса Library для добавления</param>
        public void Add(Library library)
        {
            _libraryDictionary.Add(_newId, library);
            OnAdditionChange?.Invoke(this, library);
            _newId++;
        }

        /// <summary>
        /// Удаляет объект в коллекции по переданному ключу
        /// </summary>
        /// <param name="id">Ключ объекта</param>
        /// <returns>Возвращает true если удаление произошло успешно, иначе false</returns>
        public bool Remove(int id)
        {
            if (_libraryDictionary.ContainsKey(id))
            {
                _libraryDictionary.Remove(id);
                OnRemovalChange?.Invoke(this, id);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Проверяет наличие указанного ключа в коллекции
        /// </summary>
        /// <param name="id">Ключ объекта</param>
        /// <returns>Возвращает true если ключ существует, иначе false</returns>
        public bool ContainsID(int id)
        {
            return _libraryDictionary.ContainsKey(id);
        }

        /// <summary>
        /// Возвращает объект Library по ключу id
        /// </summary>
        /// <param name="id">Ключ библиотеки</param>
        /// <returns>Возвращает объект если он найден, иначе null</returns>
        public Library? GetLibrary(int id)
        {
            if (_libraryDictionary.TryGetValue(id, out Library? library))
            {
                return library;
            }
            return null;
        }

        /// <summary>
        /// Возвращает размер коллекции
        /// </summary>
        /// <returns>Возвращает размер коллекции</returns>
        public int Size()
        {
            return _libraryDictionary.Count;
        }

        /// <summary>
        /// Возвращает IEnumerator для данной коллекции
        /// </summary>
        /// <returns>Возвращает IEnumerator для данной коллекции</returns>
        public IEnumerator GetEnumerator()
        {
            return _libraryDictionary.Values.GetEnumerator();
        }
    }
}
