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

        // result = Convert.ToSingle(x) / z;
        // print(result);

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
string name = "немного ";
string gei = "гей.";
string message = greeting + name + gei;

print (message);


int age3 = 28;
string name3 = "Yuri";

print ("Ваше имя " + name3 + " вам " + age3);


    }

}
