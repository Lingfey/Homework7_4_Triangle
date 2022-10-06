﻿//Используя Visual Studio, создайте проект по шаблону Console Application.
//Создайте программу, в которой создайте класс «Треугольник».
//В теле класса создайте три закрытых поля для описания сторон треугольника и три свойства для чтения и записи. 
//Также в теле класса создайте 3 метода: 1 - й для расчета площади треугольника, 2-й для расчета периметра треугольника,
//и 3-й для вывода информации о площади и периметре треугольника. 
//Создайте конструктор, который в качестве аргументов принимает стороны треугольника и инициализирует поля класса. 
//В методе Main() создайте экземпляр класса «Треугольник»,
//задайте произвольное значение сторон треугольника и выведите на экран значение периметра и площади треугольника.

using System;

namespace Homework7_4_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle one = new Triangle(5, 7, 3);
            one.Perimeter();
            one.Area();
            one.Info();
        }
    }
}
