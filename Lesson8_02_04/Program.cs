using Lesson8_02_04;
using System.Net.Http.Headers;
List<string> jaunuolynas = new List<string>();
Miskas spygliuociai = new Miskas(jaunuolynas);
spygliuociai.PasodintiMedį("Pušis");
spygliuociai.PasodintiMedį("Eglė");
spygliuociai.PasodintiMedį("Kadagys");
spygliuociai.PasodintiMedį("Kėnis");
Console.WriteLine("Spygliuočių medžių sąrašas: ");
for (int i = 0; i < spygliuociai.Medziai.Count; i++)
{
    Console.WriteLine(spygliuociai.Medziai[i]);
}