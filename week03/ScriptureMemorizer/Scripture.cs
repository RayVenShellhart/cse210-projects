using System;
using System.Runtime.InteropServices;


public class Scripture
{

    private List<Word> _words;

    public Scripture(string text)
    {

        _words = new List<Word>();
        string[] parts = text.Split(' ');
        foreach (string word in parts)
        {
            _words.Add(new Word(word));
        }
    }

    public bool HideRandomWords()
    {
        List<Word> visibleWords = GetWords();
        if (visibleWords.Count < 2)
        {
            return false;
        }
        Random random = new Random();
        int index1 = random.Next(visibleWords.Count);
        int index2;

        do
        {
            index2 = random.Next(visibleWords.Count);
        } while (index1 == index2);

        visibleWords[index1].Hide();
        visibleWords[index2].Hide();
        return true;
    }

    public List<Word> GetWords()
    {
        List<Word> visibleWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }
        return visibleWords;
    }

    public void GetDisplayText()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                Console.Write(new string('_', word.Show().Length) + " ");
            }
            else
            {
                Console.Write(word.Show() + " ");
            }
        }
    }

}

