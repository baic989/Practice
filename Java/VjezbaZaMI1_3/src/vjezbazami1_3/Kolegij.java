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
public class Kolegij {
    private static int idKlasa;
    private final int idKolegij;
    private String naziv;
    private int idProfesor;
    
    public Kolegij(String naziv, int idProfesor){
        this.naziv = naziv;
        this.idProfesor = idProfesor;
        
        idKolegij = ++idKlasa;
    }
    
    public void setNaziv(String naziv){
        this.naziv = naziv;
    }
    
    public String getNaziv(){
        return naziv;
    }
    
    public void setIdProfesor(int id){
        this.idProfesor = id;
    }
   
    public int getIdProfesor(){
        return idProfesor;
    }
    
    @Override
    public String toString(){
        return naziv;
    }
}
