The purpose of this project was to practice using c#, creating a UI in a windows forms app as well as practicing linking and interacting with a database using sql.
Below is the original design documents:

Pages:
1)	Sign in:
  UI > Done
  -	2 txt boxes = Username, password
  -	3 buttons = Sign in, Sign Up, Edit User
  Functionality > Done
  -	User Inputs username and password, clicks sign in. On click, If correct proceeds to purchase products. If failed prompt to try again. Checks both username and password against db.
  -	If user clicks sign up proceed to New user Sign up page.
  -	If user clicks edit user proceed to edit user page.
  Methods> Done
  -	CheckUser
  -	Button click events
  -	Clear fields

2)	New user Sign up:
  UI > Done
  -	Labels for: username, password + check, First Name, Surname, Address, phone number, member type
  -	Text boxes to accept the above
  -	Submit button, Cancel button
  Functionality > Done
  -	Onclick of submit >> checks whether all fields are populated and if passwords match
  -	If successful adds user to db, clears fields, sends user back to Sign in page or to shop
  -	If failed state reason and prompt with red outline on appropriate box
  -	On successful submission message box displayed which directs user to shopping or back to start page
  -	Cancel button clears fields and returns user to start page
  Methods > Done
  -	CheckFields
  -	CheckPassword
  -	Button click events

3)	Purchase Products:
  UI > Done
  -	Displays user information
  -	Drop down boxes: Select product, select amount
  -	Text boxes to display: Amount for 1 item, total for items with discount
  -	Add to basket button, got to checkout, cancel
  Functionality > Done
  -	Correct user info displays based on log in
  -	Able to select item from drop down and retrieves product info and displays in amount boxes
  -	Product box is populated form the products db.
  -	Total changes based on product price, amount of items and member discount
  -	Add product to basket > item name, amount of items and total amount
  -	Got to checkout > proceed to checkout page
  -	Cancel button clears fields and returns user to start page
  Methods > Done
  -	CalculateTotal
  -	Button click events
  -	ShowCustomerInformation
  -	PopulateBoxes
  -	List return methods

4)	Checkout:
  UI > Done
  -	Displays User information
  -	Displays basket information > individual items, amount of items, total price of item, overall total
  -	Button next to each item to delete
  -	Checkout button, cancel button
  Functionality > Done
  -	Displays information as above
  -	Checkout button confirms successful purchase
  -	Cancel button prompts user and states all information will be lost if cancelled	
  -	Delete item button removes item from basket and calculates new total
  Methods > Done
  -	DeleteItem
  -	ShowCustomerINformation
  -	DisplayBasket

5)	Edit User:
  UI > Done
  -	Same as New user page
  -	Delete User button
  Functionality > Done
  -	Populates user information in text boxes
  -	Submit button alters user details to what is currently in the text boxes
  -	Delete user removes the user from the db entirely. Requires password input
  Methods > Done
  -	ShowCustomerInformation
  -	Delete user
  Data:
  User:
  -	UserName
  -	password
  -	FirstName
  -	LastName
  -	Address
  -	Phone
  -	Member type
  Item:
  -	Code
  -	Description
  -	Cost
  Basket:
  -	BasketItems (List<Item>)




