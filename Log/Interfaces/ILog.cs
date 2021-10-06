namespace Log.Interfaces
{
    // Interface naming convention I ile başlar
    // Interface metodları her zaman publictir
    // Interfaceler private method içeremez
    // Interfaceden nesne oluşturulamaz

    /* 
     * Interfaceler sadece gövdesiz method içerebilir / abstract classlar hem gövdeli hem gövdesiz metod içerebilir
     * Interfaceler birden çok kere implemente edilebilir / classlar tek sefer extend edilebilir
     * Interface constructor olmaz / classlarda olabilir
     * Interfaceler sadece method (c# ta propertyler de dahil) barındırabilir // classlar metod, field, property barındarıabilir
     * Interfacelerdeki tüm metodlar implemente eden sınıf tarafından doldurulmak zorundadır / abstract classlarda sadece abtract metodlar child içinde doldurulmak zorundadır
     */

    interface ILog
    {
        void Log(string message);
    }
}
