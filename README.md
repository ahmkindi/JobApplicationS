# Resume Scanner

this is a c# blazor web app that will allow you to upload a pdf, input some key words and tell you if the words have been found. If all the words are found the sentences containing those wordsa are returned.

## Code Explanation

When a pdf is uploaded its firest check to be a PDF of a managebale size. iText is a popular PDF library that is used to convert the file into a list of sentences. A sentence is is complete once a ```terminator``` is reached. Each sentence is furher broken down into its words, hence the property (found in Resume class) is defined as:
```
public IList<IList<string>> Sentences { get; set; } = new List<IList<string>>();
```
also, some characters are not included as they will affect the word search, these are defined in ```notIncluded``` array. Now the key words can be inputted, when the submit button is clicked a for loop will iterate over the sentences and check if it contains a word that is equal to each of the given words. Each sentence that contains a key word is added to another property found in the Filter class:
```
public IList<string> Sentences { get; set; } = new List<string>();
```
a boolean array keeps track of the key words found, if the array is all true then all the words are found and the sentences are shown.


## How to run
Make sure to have Docker installed in your machine, check this with ```docker version```.

* Download the zip or git clone of this repository
* In the main directory (the one with JobApplicationS.sln) run: ```docker build -t program -f Dockerfile .. ```
* Now you can run ```docker run -p 8080:80 program``` at any time in your terminal
* To view the application navigate to ```http://localhost:8080/```
