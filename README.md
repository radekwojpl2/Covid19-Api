# Covid19-Api

## Requirements
1. Git
2. .Net Core 3.0 
3. Linux (in my case Ubuntu 18.04)

Thise repo uses dataset from https://github.com/datasets/covid-19/tree/352f740f6948aed89c9d7232cbab7705e6739efd

## CsvParser

This app needs arguments to run

### Arguments

1. path to folder with csv data
2. path to folder where json file will be saved
3. webMode

### Example

1. Run from ClI $ dotnet run /home/radek/Desktop/Covid19-Api/Covid19-Api/dataset/data/ /home/radek/Desktop/Covid19-Api/Covid19-Api/JsonData
2. Run from binary  $./CsvParser /home/radek/Desktop/Covid19-Api/Covid19-Api/dataset/data/ /home/radek/Desktop/Covid19-Api/Covid19-Api/JsonData

#### WebMode

dotnet run https://raw.githubusercontent.com/datasets/covid-19/master/data/ /home/radek/Desktop/Covid19-Api/Covid19-Api/JsonData true

#### Run Csvparser from docker file
Go to CsvParser project and 

Create new VOLUME name DataVolume2 then run


"docker docker build -t radekwojpl2/csvparser ."  then


"docker run -ti --rm -v DataVolume2:/app/data radekwojpl2/csvparser"
