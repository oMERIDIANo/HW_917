using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment : MonoBehaviour
{
    public string string1 = ""; //Type inside inspector
    public string[] stringArray; //Type inside inspector

    // Start is called before the first frame update
    void Start()
    {
        numbersThreeAndSeven();
        findCommonLetter(string1);
        oneLetter(stringArray);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void numbersThreeAndSeven()
    {
        for (int x = 0; x < 1000; x++)
        {
            string s = x.ToString();

            if (s.Contains("3") && s.Contains("7"))
            {
                Debug.Log(x);
            }
        }
    }

    void findCommonLetter(string string1)
    {
        Dictionary<char, int> dict = new Dictionary<char, int>();

        foreach (char c in string1)
        {
            if (dict.ContainsKey(c))
            {
                dict[c]++;
            }
            else
            {
                dict.Add(c, 1);
            }
        }

        KeyValuePair<char, int> currentLetterWithHighestNumber;

        foreach (KeyValuePair<char, int> kvp in dict)
        {
            if (kvp.Value > currentLetterWithHighestNumber.Value)
            {
                currentLetterWithHighestNumber = kvp;
            }
        }

        Debug.Log("The most common letter in your string is " + currentLetterWithHighestNumber.Key);
    }

    void oneLetter(string[] s)
    {
        string l = " ";

        Dictionary<char, int> dict = new Dictionary<char, int>();

        for (int x = 0; x < s.Length; x++)
        {
            foreach (char c in s[x])
            {
                if (dict.ContainsKey(c))
                {
                    dict[c]++;
                }
                else
                {
                    dict.Add(c, 1);
                }
            }
        }

        foreach (KeyValuePair<char, int> kvp in dict)
        {
            if (kvp.Value == 1)
            {
                l += kvp.Key + " ";
            }
        }

        Debug.Log("One letter: " + l);
    }
}
