using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScripts : MonoBehaviour
{
    // основные типы данных, языка  C# int (целочисленные) | float (до 7 знаков после запятой) | string (строковый тип string c = "всё что угодно")| bool (логический тип true или false)
    // + - * /%

    void Start()
    {

        // простое деление
        float result;
        int x, z;

        x = 10;
        z = 3;

        result = Convert.ToSingle(x) / z;
        print(result);

        // определение времени
        int timeInMinets = 130;
        int hour;
        int minute;
        hour = timeInMinets / 60;
        minute = timeInMinets % 60;
        print("hours " + hour);
        print("minuets " + minute);


        int age = 17;
        age = age + 1;  // одно
        age += 1;      // и тоже
        age -= 2;
        age *= 3;
        age /= 4;


        // логические операции

        // == != > >= < <= ()

        int age2 = 17;
        bool accesIsAllowed;

        accesIsAllowed = age2 >= 18;
        print(accesIsAllowed);


        string greeting = "Слава ";
        string name = "точно ";
        string gei = "гей.";
        string message = greeting + name + gei;

        print(message);


        int age3 = 28;
        string name3 = "Yuri";

        print("Ваше имя " + name3 + " вам " + age3);

        int thunder;
        string lightning = "25";
        thunder = Convert.ToInt32(lightning);
        print(thunder);

        float result1;
        int x1 = 5, y = 2;
        result1 = Convert.ToSingle(x1) / y;
        print(result1);

        int trigger = 1;
        bool triggerInBoolean = Convert.ToBoolean(trigger);
        print(triggerInBoolean);

        int reconvert = Convert.ToInt32(triggerInBoolean);
        print(reconvert);


        int i = 0;
        print(i++);
        print(i);

        // int health;
        // int armor;
        // int damage;
        // int presentConverter = 100;

        // print("введите количество здоровья: ");
        // health = Convert.ToInt32(print());
        // print = 1;
        // print("введите количество брони: ");
        // armor = Convert.ToInt32(1);
        // print("введите количество урона: ");
        // damage = Convert.ToInt32(print());

        // health -= damage * armor / presentConverter;

        // print($"Вам нанесли {damage}урона. У вас осталось {health}здоровья!!!")


        // if если | else иначе | else if иначе если...
        int age4;
        age4 = 12;
        if (age4 >= 18)
        {
            print("добро пожаловать в наш бар!");
            print("что будете пить?");
        }
        else
        {
            print("вы слишком юны");
            print("приходите к нам через: " + (18 - age4) + " лет");
        }


        // логическое и &&(амперсант)
        // x | y | x && y 
        // 1 | 1 |   1
        // 1 | 0 |   0
        // 0 | 1 |   0
        // 0 | 0 |   0

        // логическое или ||
        // x | y | x && y 
        // 1 | 1 |   1
        // 1 | 0 |   1
        // 0 | 1 |   1
        // 0 | 0 |   0

        int money = 450;
        int level = 8;

        if (money >= 500 || level > 9)
        {
            print("Проходи! добро пожаловать в гильдию!");
        }
        else
        {
            print("вас выпнули за дверь!");
        }



        string dayOfWeek;
        dayOfWeek = "понедельник";

        switch (dayOfWeek)
        {
            case "понедельник":
            case "суббота":
            case "воскресение":
                print("кушаем");
                break;
            case "вторник":
                print("делаем дз");
                break;
            case "среда":
                print("лежим в постели");
                break;
            default:
                print("я такого дня не знаю");
                break;
        }

        int age5;
        age5 = 5;
        while (age5-- > 0)
        {
            print("с днём рождения!!!");
        }


        for (int a = 0; a <= 10; a++)
        {
            print(a);
        }


    }



}
