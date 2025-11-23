using System;

public interface DataMethods
{

    bool check_exists_file();
    void add_data(Registierung registierung);
    List<Registierung> Call_data(); 
    void read_file();

}