#  Arçelik Smart Api Remote with C#
Wellcome to my repo. Introducting the Arçelik , Grundig and Beko Smart TV Remote api within C#
# How to use the api
Here example power off command :

    string ipoftv = "192.168.1.45"
    InteractiveAPI.tvip = ipoftv
    InteractiveAPI.Power();
# There is all commands:
IP Input:

     InteractiveAPI.tvip = /* ip of the tv*/;
Power off:

    InteractiveAPI.Power();
1 Keypad:

    InteractiveAPI.K1();
2 Keypad:


    InteractiveAPI.K2();
....
9 Keypad:

    InteractiveAPI.K9();
0 Keypad:



    InteractiveAPI.K0();
Favorite:

    InteractiveAPI.Fav();


Teletext:

    InteractiveAPI.Txt();
Exit:

    InteractiveAPI.Exit();
Menu:

    InteractiveAPI.Menu();
Back
        
    InteractiveAPI.Back();
Up:

    InteractiveAPI.Yukari();
Down

    InteractiveAPI.Asagi();
Left:

    InteractiveAPI.Sol();

Right

    InteractiveAPI.Sag();
Middle:

    InteractiveAPI.Orta();
Tools:

	InteractiveAPI.Tools();

Volume + :


    InteractiveAPI.Varti();
Volume - :

	InteractiveAPI.Veksi();
Mute:

    InteractiveAPI.Mute();

Program + :

    InteractiveAPI.Parti();

Program - :

    InteractiveAPI.Peksi();

?:

    InteractiveAPI.SoruIsaret();
Red:

    InteractiveAPI.Kirmizi();
Green

    InteractiveAPI.Yesil();
Yellow

	InteractiveAPI.Sari();
Blue

	InteractiveAPI.Mavi();
Prev Video:

    InteractiveAPI.OncekiVid();
Next Video:

	InteractiveAPI.SonrakiVid();
Rewind:

	InteractiveAPI.GeriSar(); 
Fast Forward
       			
	InteractiveAPI.IleriSar();
Play Video:

    InteractiveAPI.Oynat();
Pause Video

    InteractiveAPI.Duraklat();
Internet (Apps):

    InteractiveAPI.Internet();
Guide:

    InteractiveAPI.Guide();
Source:

    InteractiveAPI.Source();
Record TV Show:
		
	InteractiveAPI.Kaydet();
Stop Video :

    InteractiveAPI.Durdur();
Subtitles:

    InteractiveAPI.Sub();
Dubbing:

    InteractiveAPI.Dub();
