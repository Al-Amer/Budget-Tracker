using System;

public interface DataMethods
{
    void create_file();
    bool check_exists_file();
    void add_data(User user);
    List<User> Call_data(); 
    void read_file();
   
}