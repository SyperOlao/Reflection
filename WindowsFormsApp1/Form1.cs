using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using ClassLibrary2;
using System.Reflection;
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
            var asm = Assembly.Load("ClassLibrary2");
            var types = asm.GetTypes();
            var result = types.Where(x => x.GetInterface("IFurniture") != null);
            label1.Text = "Выберете класс из списка: ";
            label2.Text = "Выполненый метод: ";
            label3.Text = String.Empty;
            foreach (var r in result)
            {
                comboBox1.Items.Add(r);
            }

            label1.Text += comboBox1.SelectedText;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = comboBox1.SelectedItem;
            label1.Text = item.ToString();
            var type = typeof(IFurniture);
            
            comboBox2.Items.Clear();
            foreach (var method in type.GetMethods())
            {
                comboBox2.Items.Add(method.Name);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var asm = Assembly.Load("ClassLibrary2");
            var type = asm.GetType(comboBox1.SelectedItem.ToString());
            var result = type.GetMethod(comboBox2.SelectedItem.ToString());
            ConstructorInfo ctor = type.GetConstructor(new[] { typeof(int), typeof(string), typeof(int), typeof(int)});
            object classInstance = Activator.CreateInstance(type, new object[] { 10, "gh", 67, 56 });
            if (!(result is null))
            {
                var result1 = ctor.Invoke(classInstance, null);
                if (!(result1 is null)) label3.Text = result1.ToString();
            }
        }
    }
}