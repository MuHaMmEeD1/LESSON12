



namespace C__LESSON_12
{
    class Programg
    {

        static void Main(string[] args)
        {

            DVD d1 = new DVD("DVD", "BLE", 2.5F, 4, 2);
            Flash f1 = new Flash("FLASH", "FLASH_CARD", 3F, 9, 7);
            HDD h1 = new HDD("HDD", "HDD16", 2F, 20, 7);


            d1.PrintDeviceİnfo();
            f1.PrintDeviceİnfo();
            h1.PrintDeviceİnfo();


        }

    }

}














