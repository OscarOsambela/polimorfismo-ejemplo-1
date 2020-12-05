using System;

class MainClass {
  public static void Main (string[] args) {
    Auto auto = new Auto(33000, "rojo");
    BMW bmw = new BMW("BMW", 40000, "negro");
    Audi audi = new Audi("Audi", 36000, "azúl");
  }
}
class Auto{
  public int HP{get;set;}
  public string COLOR{get;set;}

  public Auto(int hp, string color){
    this.HP = hp;
    this.COLOR = color;
  }
  public void MostrarDetalles(){
    Console.WriteLine("HP: {0}, Color: {1}", HP, COLOR);
  }
  public void Reparar(){
    Console.WriteLine("Auto reparado");
  }
}

class BMW:Auto{
  private string marca = "BMW";
  public string MODELO{get;set;}
  public BMW(string modelo, int hp, string color):base(hp, color){
    this.MODELO = modelo;
  }
  public void MostrarDetalles(){
    Console.WriteLine("Modelo: {0}, Marca: {1}, HP: {2}, Color: {3}", MODELO, marca, HP, COLOR);
  }
   public void Reparar(){
    Console.WriteLine("");
  }
}

class Audi:Auto{
  private string marca = "Audi";
  public string MODELO{get;set;}
  public Audi(string modelo, int hp, string color):base(hp, color){
    this.MODELO = modelo;
  }
  public void MostrarDetalles(){
    Console.WriteLine("");
  }
   public void Reparar(){
    Console.WriteLine("");
  }
}