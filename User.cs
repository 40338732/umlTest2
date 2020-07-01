
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
  
public class User : Person {

    public User() {
    }

    public int UserId { get; set; }

    public string Name { get; set; }

    public string Password;



    public DateTime CreateTime { get; set; }

    public string Role;

    public string PhoneNumber;

    public string State;

    public int BorrowedNumber;





    public void CreateUserAccount() {
        // TODO implement here
    }

    public void BorrowBook() {
        // TODO implement here
    }

    public void ReturnBook() {
        // TODO implement here
    }

    /// <summary>
    /// @return
    /// </summary>
    public string ViewUserAccount() {
        // TODO implement here
        return "\nUserID:  " + this.UserId + "\nName: " + this.Name + "\nDate Time: " + this.CreateTime;
                                              
    }

}