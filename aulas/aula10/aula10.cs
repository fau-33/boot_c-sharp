using System;

class aula10{

  enum DiasSemana{Domingo,segunda,terça,quarta,quinta,sexta,sabado};

  static void Main(){
    //DiasSemana ds = (DiasSemana)0;
    int ds = (int)DiasSemana.sexta;

    Console.WriteLine(ds);
  }

}