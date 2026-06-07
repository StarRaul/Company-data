using System;
using System.Collections.Generic;
using System.IO;
class Cuvant
{
    String text;
    int id;
    public Cuvant(String text, int id)
    {
        this.text = text;
        this.id = id;
    }
    public String Text
    {
        get { return text; }
        set { this.text = value; }
    }
    public int Id
    {
        get { return id; }
        set { this.id = value; }
    }
    public static List<Cuvant> citeste_cuvinte(String nume_fisier)
    {
        List<Cuvant> lista = new List<Cuvant>();
        FileStream fs = null;
        StreamReader sr = null;
        try
        {
            fs = new FileStream(nume_fisier, FileMode.Open, FileAccess.Read);
            sr = new StreamReader(fs);
            for (; ; )
            {
                String linie = sr.ReadLine();
                if (linie == null) break;//daca s-a citit tot
                int index = linie.IndexOf(";");
                if (index >= 0)
                {
                    String temp_text = linie.Substring(1, index - 2);
                    linie = linie.Substring(index + 1);
                    try
                    {
                        lista.Add(new Cuvant(temp_text, Convert.ToInt32(linie)));
                    }
                    catch (Exception) { }
                    ;
                }
            }
        }
        catch (System.Exception) { }
        finally
        {
            if (sr != null) sr.Close();
            if (fs != null) fs.Close();
        }
        return lista;
    }
};
