using System;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
// skapar två kurser. Matematik har bara plats för 2 studerande
// vilket vi använder nedan för att visa att kapacitetsregeln funkar. 
var matte = new Course("Matematik", 2);
var fysik = new Course("Fysik", 3);

// skapar tre studerande
var abodi = new Student("Abodi");
var bob = new Student("Bob");
var carla = new Student("Carla");

Console.WriteLine("=== Anmälan (från olika håll) ===");
matte.Enroll(abodi); // Anmälan via kursen.
bob.Join(matte); // Anmälan via studerande
carla.join(matte); // ska uppge att kursen är full

Console.WriteLine();
Console.WriteLine("=== Fler anmälningar ===");
abodi.join(fysik);
bob.join(Fysik);

Console.WriteLine();
Console.WriteLine("=== Status just nu ===");
Console.WriteLine(matte);
Console.WriteLine(fysik);

Console.WriteLine();
matte.RollCall();
fysik.Rollcall();

Console.WriteLine();
abodi.Schedule();
bob.Schedule();
carla.Schedule(); // Ska vara tomt, hon kom aldrig in.

Console.WriteLine();
Console.WriteLine("=== Avanmälan (från olika håll) ===");
matte.Remove(bob); //Avanmälan via kursen.
abodi.Leave(fysik); // Avanmälan via studerande
carla.Leave(matte); // Ska inte krascha trots att hon gick aldrig gick där.

Console.WriteLine();
Console.WriteLine("=== Status efteravanmälan ===");
Console.WriteLine(matte);
Console.WriteLine(fysik);
matte.Rollcall();
fysik.Rollcall();
abodi.Schedule();
bob.Schedule();
