// phonetic alphabet encoder (c++)
#include <iostream>
#include <stdio.h>
#include <vector>
#include <map>
#include <string>
using namespace std;

int main()
{
    // chapter 1: introduction
    cout << "\x1B[35mPHONETIC ALPHABET ENCODER!\033[0m \n";
    cout << "insert a text right bellow: \n";
    while (true) {
        string txt;
        getline(cin, txt);

        // creating a list with chars of txt
        vector<char> norm;
        for (int y = 0; y <= txt.size(); y++)
            norm.push_back(txt[y]);

        // creating the other list
        vector<char> fin;
        for (int x = 0; x <= txt.size(); x++)
            fin.push_back(txt[x]);

        // creating keys and values with codes
        map<char, vector<string>> codes;
        codes['a'].push_back("alpha ");
        codes['b'].push_back("bravo ");
        codes['c'].push_back("charlie ");
        codes['d'].push_back("delta ");
        codes['e'].push_back("echo ");
        codes['f'].push_back("foxtrot ");
        codes['g'].push_back("golf ");
        codes['h'].push_back("hotel ");
        codes['i'].push_back("india ");
        codes['j'].push_back("juliet ");
        codes['k'].push_back("kilo ");
        codes['l'].push_back("lima ");
        codes['m'].push_back("mike ");
        codes['n'].push_back("november ");
        codes['o'].push_back("oscar ");
        codes['p'].push_back("papa ");
        codes['q'].push_back("quebec ");
        codes['r'].push_back("romeo ");
        codes['s'].push_back("sierra ");
        codes['t'].push_back("tango ");
        codes['u'].push_back("uniform ");
        codes['v'].push_back("victor ");
        codes['w'].push_back("whiskey ");
        codes['x'].push_back("xray ");
        codes['y'].push_back("yankeey ");
        codes['z'].push_back("zulu ");

        // chapter 2: the translating
        for (int z = 0; z <= txt.size(); z++) {
            if (codes.find(fin[z]) == codes.end()) {
                cout << fin[z] << ' ';
            }
            else {
                cout << codes[fin[z]][0];
            }
        }
        cout << "\n\nshow me another text. \n";
        continue;
    }
}
