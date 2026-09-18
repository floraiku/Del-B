using System;
using System.Runtime.InteropServices;
// skapar två kurser. Matematik har bara plats för 2 studerande
// vilket vi använder nedan för att visa att kapacitetsregeln funkar. 
var matte = new Course("Matematik", 2);
var fysik = new Course("Fysik", 3);

// skapar tre studerande
var abodi = new Student("Abodi");
var hamodi = new Student("Hamodi");
var sara = new Student("Sara");

Console.WriteLine("=== Anmälan (från olika håll) ===");