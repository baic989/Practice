/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package vjezbazami1_3;

import java.util.ArrayList;
import java.util.Arrays;

/**
 *
 * @author hrvoje
 */
public class Student extends Osoba {
    private static int idKlasa;
    private final int idStudent;
    Adresa adresa;
    ArrayList upisaniKolegiji = new ArrayList();
    
    public Student(String Ime, String Prezime, Adresa adresa){
        this.ime = Ime;
        this.prezime = Prezime;
        this.adresa = adresa;
        
        idStudent = ++idKlasa;
    }
    
    public int getId(){
        return idStudent;
    }
    
    public void upisiKolegij(Kolegij ... args){
        upisaniKolegiji.addAll(Arrays.asList(args));
    }
    
    @Override
    public String toString(){
        return ime + " " + prezime + " upisani kolegiji: " + upisaniKolegiji;
    }
}
