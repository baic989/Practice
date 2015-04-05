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
abstract class Osoba {
    protected String ime;
    protected String prezime;
    
    public void setIme(String ime){
        this.ime = ime;
    }
    
    public String getIme(){
        return ime;
    }
    
    public void setPrezime(String prezime){
        this.prezime = prezime;
    }
    
    public String getPrezime(){
        return prezime;
    }
}
