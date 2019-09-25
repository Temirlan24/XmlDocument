using System;
using System.Xml;
using System.Collections.Generic;
namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1. List<Item> items = new List<Item>();

            XmlDocument document = new XmlDocument();
            document.Load("https://habrahabr.ru/rss/interesting/");
            XmlNodeList rootElement = document.SelectNodes("rss/channel/item");

            foreach (XmlNode itemElement in rootElement)
            {
                var titleElement = itemElement.SelectSingleNode("title");
                var linkElement = itemElement.SelectSingleNode("link");
                var descriptionElement = itemElement.SelectSingleNode("description");
                var pubDateElement = itemElement.SelectSingleNode("pubDate");

                items.Add(new Item { Title = titleElement.InnerText, Link = linkElement.InnerText,
                    Description = descriptionElement.InnerText, PubDate = pubDateElement.InnerText
                });

            }

            foreach (var item in items)
            {
                Console.WriteLine(item.Title);
                Console.WriteLine(item.Link);
                Console.WriteLine(item.PubDate);
                Console.WriteLine(item.Description);
                }
                */
            List<Student> students = new List<Student>
            {
                new Student
                {
                    Id=1,
                    Name="Жигер Данилович",
                    Course=2,
                    Profession="Экономист"
                },
            new Student
            {
                Id = 2,
                Name = "Харитон Платонович",
                Course = 3,
                Profession="Web-дизайнер"
            },
            new Student
            {
                Id = 3,
                Name = "Эдуард Романович",
                Course = 4,
                Profession="Врач"
            },
        };
            XmlDocument document = new XmlDocument();
            var declaration = document.CreateXmlDeclaration("1.0", "utf-8", string.Empty);

            var rootElement = document.CreateElement("Students");

            foreach (var student in students)
            {
                var studentElement = document.CreateElement("student");
                var idElement = document.CreateElement("id");
                var nameElement = document.CreateElement("name");
                var courseElement = document.CreateElement("course");
                var professionElement = document.CreateElement("profession");

                idElement.InnerText = student.Id.ToString();
                nameElement.InnerText = student.Name;
                courseElement.InnerText = student.Course.ToString();
                professionElement.InnerText = student.Profession;

                studentElement.AppendChild(idElement);
                studentElement.AppendChild(nameElement);
                studentElement.AppendChild(courseElement);
                studentElement.AppendChild(professionElement);

                rootElement.AppendChild(studentElement);
            }
            document.AppendChild(declaration);
            document.AppendChild(rootElement);
            document.Save("Students.xml");

        }
    }
}