using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using ClassLibrary2;

    /*
     * Взять за основу задачу 5. Должно быть не менее 3 классов,
     * которые наследуются от абстрактного класса. Используя рефлексию
     * реализовать возможность создания и вызова методов данных классов на форме.
     * Написать код, который принимает путь к библиотеке классов и ищет все классы,
     * которые реализуют интерфейс. Далее получают всю информацию о данных классах,
     * и возвращают список из названий классов. На форме реализовать «дроплаун» с названиями классов.
     * При выборе класса на форму должны динамически подгружаться все методы класса с возможностью
     * ввода параметров пользователем.
     * При нажатии кнопки «Выполнить» должен создаваться объект и выполняться выбранный метод.
     */

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var instances = from t in Assembly.GetExecutingAssembly().GetTypes()
                where t.GetInterfaces().Contains(typeof(IFurniture))
                      && t.GetConstructor(Type.EmptyTypes) != null
                select Activator.CreateInstance(t) as IFurniture;
            
            foreach (var instance in instances)
            {
                label1.Text += instance.AnyFurnitureMethod1();
            }
            
            
            Closet cl = new Closet("h", 1, 2);
            Console.WriteLine(cl.NumOfShelves);
        }
    }
}