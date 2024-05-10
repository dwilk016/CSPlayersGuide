// Level 5: Variables

/*
Notes:
Variables - are named locations used to store data in memory.

Declaring - reserves the space in memory for the variable. 

Initializing - is the first time you assign data to a variable. This can be done when you
declare the variable or later in the program. 

Reading a variable from memory does not change the value of the variable. 

You can declare multiple variables of the same type at once.
  int x, y, z;

You can assign multiple variables the same value at once.
  x = y = z = 0;

You can declare and initialize variables at the same time.
  int x = 0;

Nameing Conventions:
1. Variable must start with a letter (a-z, A-Z) or underscore (_)
  1.a Underscores mean that the variable is interal to a class (ie. Private), but can also be ambigous. 
  It is recommended that you use m_ or s_ for Member field or Static field respectivly. Member fields are
  fields private to each object. Static fields are fields private to the class, but shared amoung the objects.
  string m_color = "Blue";
  int s_wheels = 4;

2. After the start you can use numbers (0-9)
  2.a It is generally bad form for number your variables. Remember to be descriptive. 
  double pi315 = 3.15;

3. Most symbols and whitespace are banned. 
  double Golden Ratio = 1.6180339887; // banned
  double Golden-Ratio = 1.6180339887; // banned

4. You cannot use keywords like class, main, for, is. 
  4.a unless you use the @ symbol in front. 
  int class = 5; // banned
  int @class = 5; // ok, but not recommened

5. Use accurate names without abriviations
  var a; // NO
  var descriptor; // YES

6. Do NOT use abbreviations (this isn't the Army)
  var NCO;
  var NonCommisionedOfficer

7. Do NOT worry about long names
  var ThirdDescriptorOfThingNamer

8. Names ending in numbers is a sign of poor naming. 
  var object1;
  var object2;
  var object3;

9. Avoid generic names like item, data, text, and number

10. UseCamelCase
  lowerCamelCase for variables
  UpperCamelCase for everything else

*/

/*
Knowledge Check: Variables (25 XP)
1. Type, Name, Value
2. True
3. No
4. answer, value1, delete_me, PI
*/



