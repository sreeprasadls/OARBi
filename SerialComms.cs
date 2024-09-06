using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using UnityEngine.UI;
using System.Text;
using System;

public class SerialComms : MonoBehaviour {

    [Header("com port number")]
    public string com_port_number;

    //serial port
    private SerialPort serial_port;

    // Use this for initialization
    void Start(){

        this.init_serial();
    }

    private void init_serial() {

        try{
            this.serial_port = new SerialPort(this.com_port_number);
            this.serial_port.BaudRate = 9600;
            this.serial_port.Encoding = Encoding.ASCII;

            serial_port.StopBits = StopBits.One;
            serial_port.DataBits = 8;
            serial_port.Parity = Parity.None;

            this.serial_port.Open();
        }
        catch (Exception e){

            Debug.LogError("init com port error……" + e);
        }

    }

    public void TriggerFirst() {

        try
        {
            this.serial_port.Write("" + 1);
            //return true;
        }
        catch (Exception e)
        {
            Debug.LogError("Error on trigger: " + e);
            //return false;
            throw;
        }
    }

    public void TriggerSecond() {

        try
        {
            this.serial_port.Write("" + 2);
            //return true;
        }
        catch (Exception e)
        {
            Debug.LogError("Error on trigger: " + e);
            //return false;
            throw;
        }
    }

    public void TriggerThird() {

        try
        {
            this.serial_port.Write("" + 3);
            //return true;
        }
        catch (Exception e)
        {
            Debug.LogError("Error on trigger: " + e);
            //return false;
            throw;
        }
    }

}
