# EB_Erkennung

Programm zur Erkennung von Produkten und Auswertung der Nötigen Aktion (Blasentausch oder Blasenwäsche) + Upload in die Cloud

Test Bilder und XML Dateien können im Ordner "Test_Data" gefunden werden

# Wichtig für OCR

Damit die OCR richtig funktioniert müssen einige Schritte vorher erledigt werden:

1. Die Datei "deu.traineddata" muss heruntergeladen werden
2. Bei ImageForm.cs muss die Zeile 109 angepasst werden: den Pfad wie in der Zeile, von der datei "deu.traineddata", genauso angeben
