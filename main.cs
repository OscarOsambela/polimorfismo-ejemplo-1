using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {

  Auto auto = new Auto(3000, "Rojo");
  BMW bmw = new BMW("A4", 2000, "negro");
  Audi audi = new Audi("M3", 2500, "gris");
  M4 m4 = new M4("M4", 2500, "verde");

  auto.MostrarDetalles();
  auto.Reparar();
  bmw.MostrarDetalles();
  bmw.Reparar();
  audi.MostrarDetalles();
  audi.Reparar();
	m4.MostrarDetalles();
  m4.Reparar();

  Console.WriteLine("=========================");

  var autos = new List<Auto>{
		new Audi("M3", 2500, "gris"),
    new BMW("A4", 2000, "negro"),
    new M4("M4", 2500, "verde")
	};
  foreach(var a in autos){
    a.MostrarDetalles();
    a.Reparar();
  }

  }
}

class Auto{
  public int HP{get;set;}
  public string COLOR{get;set;}

  public Auto(int hp, string color){
    this.HP = hp;
    this.COLOR = color;
  }
  public virtual void MostrarDetalles(){
    Console.WriteLine("HP: {0}, Color: {1}", HP, COLOR);
  }
  public virtual void Reparar(){
    Console.WriteLine("Auto reparado");
  }
}

class BMW:Auto{
  private string marca = "BMW";
  public string MODELO{get;set;}
  public BMW(string modelo, int hp, string color):base(hp, color){
    this.MODELO = modelo;
  }
  public override void MostrarDetalles(){
    Console.WriteLine("Modelo: {0}, Marca: {1}, HP: {2}, Color: {3}", MODELO, marca, HP, COLOR);
  }
   public sealed override void Reparar(){
    Console.WriteLine("El BWM {0} está reparado", MODELO);
  }
}

class Audi:Auto{
  private string marca = "Audi";
  public string MODELO{get;set;}
  public Audi(string modelo, int hp, string color):base(hp, color){
    this.MODELO = modelo;
  }
  public override void MostrarDetalles(){
    Console.WriteLine("Modelo: {0}, Marca: {1}, HP: {2}, Color: {3}", MODELO, marca, HP, COLOR);
  }
   public override void Reparar(){
    Console.WriteLine("El BWM {0} está reparado", MODELO);
  }
}

class M4:BMW{
	public M4(string modelo, int hp, string color):base(modelo, hp, color){}
}

//Nota.-
//solo se puede sellar metodos que han sido rescritos
