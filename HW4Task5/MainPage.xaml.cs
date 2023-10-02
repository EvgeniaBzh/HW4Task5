using System;
using System.Collections.Generic;
using HW4Task5.Resources;
using System.Linq;
using Microsoft.Maui.Controls;

namespace HW4Task5
{
    public partial class MainPage : ContentPage
    {
        private List<Goods> GoodList; // Ось ваш список товарів
        private List<Goods> AllGoods; // Список всіх товарів
        private int currentProductIndex = 0; // Індекс поточного товару

        public MainPage()
        {
            InitializeComponent();
            AllGoods = new List<Goods>();
            AllGoods.Add(new Products
            {
                Price = 10.99M,
                Name = "Mango",
                CountryOfOrigin = "Japan",
                PackingDate = new DateTime(2023, 10, 2),
                Description = "Yellow sort",
                ExpirationDate = new DateTime(2023, 11, 3),
                Amount = 5,
                Unit = "kg"
            });

            AllGoods.Add(new Books
            {
                Price = 19.99M,
                Name = "Pride & Prejudice",
                CountryOfOrigin = "GB",
                PackingDate = new DateTime(2022, 11, 22),
                Description = "1813 novel of manners",
                NumberOfPages = 300,
                ListOfAuthors = new List<string> { "Jane Austen" },
                PublishingHouse = "-"
            });

            AllGoods.Add(new Products
            {
                Price = 2.5M,
                Name = "Bread",
                CountryOfOrigin = "Ukraine",
                PackingDate = new DateTime(2023, 10, 2),
                Description = "Toast bread",
                ExpirationDate = new DateTime(2023, 10, 7),
                Amount = 10,
                Unit = "kg"
            });

            AllGoods.Add(new Books
            {
                Price = 17.34M,
                Name = "Coraline",
                CountryOfOrigin = "USA",
                PackingDate = new DateTime(2022, 11, 22),
                Description = "A novel for readers of all ages",
                NumberOfPages = 300,
                ListOfAuthors = new List<string> { " Neil Gaiman" },
                PublishingHouse = "-"
            });

            GoodList = new List<Goods>(); // Ініціалізація списку товарів
            UpdateTable(); // Викликаємо метод для оновлення таблиці при ініціалізації
        }

        private void ДодатиТовар_Clicked(object sender, EventArgs e)
        {
            if (AllGoods.Count == 0)
                return; // Немає доступних товарів для додавання

            // Додавання товару до списку
            var productToAdd = AllGoods[currentProductIndex];
            GoodList.Add(productToAdd);
            UpdateTable();

            // Збільшуємо індекс для наступного додавання
            currentProductIndex = (currentProductIndex + 1) % AllGoods.Count;
        }

        private void ВидалитиТовар_Clicked(object sender, EventArgs e)
        {
            // Видалення останнього доданого товару зі списку
            if (GoodList.Count > 0)
            {
                GoodList.RemoveAt(GoodList.Count - 1);
                UpdateTable(); // Оновлення таблиці
            }
        }

        private void UpdateTable()
        {
            // Оновлення таблиці на основі списку товарів
            ТовариGrid.ItemsSource = null; // Спочатку очистіть джерело даних
            ТовариGrid.ItemsSource = GoodList; // Встановіть список як нове джерело даних
        }
    }
}