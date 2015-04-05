/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package vjezbazami1_3;

/**
 *
 * @author hrvoje
 */
public class Profesor extends Osoba {
    private static int idKlasa;
    private final int idProfesor;
    Adresa adresa;
    
    public Profesor(String Ime, String Prezime, Adresa adresa){
        this.ime = Ime;
        this.prezime = Prezime;
        this.adresa = adresa;
        
        idProfesor = ++idKlasa;
    }
    
    public int getId(){
        return idProfesor;
    }
}
