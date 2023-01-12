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

print (message);


int age3 = 28;
string name3 = "Yuri";

print ("Ваше имя " + name3 + " вам " + age3);

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

int health;
int armor;
int damage;
int presentConverter = 100;

print("введите количество здоровья: ");
health = Convert.ToInt32(print());
print = 1;
print("введите количество брони: ");
armor = Convert.ToInt32(1);
print("введите количество урона: ");
damage = Convert.ToInt32(print());

health -= damage * armor / presentConverter;

print($"Вам нанесли {damage}урона. У вас осталось {health}здоровья!!!")



}



}
