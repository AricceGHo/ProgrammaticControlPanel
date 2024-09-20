using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammaticControlPanel
{
    internal class Datas
    {
    }
    public class RawData
    {
        [DisplayName("Дата")]
        public string DateString { get; set; }
        [DisplayName("Время")]

        public string TimeString { get; set; }
        [DisplayName("Ауд/зал")]
        public string Place { get; set; }
        [DisplayName("Статус")]
        public string Status { get; set; }
        [DisplayName("Филиал")]
        public string Filial { get; set; }
        [DisplayName("Программа")]
        public string Program { get; set; }
        [DisplayName("Группа")]
        public string Group { get; set; }
        [DisplayName("Преподаватель")]
        public string Teacher { get; set; }
        [DisplayName("Тема")]
        public string Subject { get; set; }
        [DisplayName("Описание")]
        public string Note { get; set; }
        [DisplayName("Записано")]
        public string Recorded { get; set; }
        [DisplayName("Пришло")]
        public string HasCome { get; set; }
        [DisplayName("Пропусков всего")]
        public string MissedAll { get; set; }
        [DisplayName("Пропусков по уваж. причине")]
        public string MissedAllowed { get; set; }
        [DisplayName("Продолж. ас/ч")]
        public string AS { get; set; }
        [DisplayName("Продолж. ак/ч")]
        public string AK { get; set; }
        public override string ToString()
        {
            return $"{DateString} {TimeString} {Place} {Status} {Filial} {Program} {Group} {Teacher} {Subject} {Note} {Recorded} {HasCome} {MissedAll} {MissedAllowed} {AS} {AK}  ";
        }

    }
    public class CommonData
    {
        [DisplayName("Преподаватель")]
        public string Teacher { get; set; }
        [DisplayName("Продолж. ас/ч")]
        public double AS { get; set; }
        [DisplayName("Продолж. ак/ч")]
        public double AK { get; set; }
        [DisplayName("Кол-во гр.")]
        public int grCount { get; set; }
        [DisplayName("Кол-во инд.")]
        public int indCount { get; set; }
        [DisplayName("Кол-во общее.")]
        public int fullCount { get; set; }

    }

    public class GroupRawData
    {
        [DisplayName("Преподаватель")]
        public string Teacher { get; set; }
        [DisplayName("Урок")]
        public string Lession { get; set; }
        [DisplayName("Кол-во")]
        public float Count { get; set; }
        [DisplayName("Тип")]
        public LessionType LessionType { get; set; }

    }
    public class GroupLoadData
    {
        [DisplayName("Преподаватель")]
        public string Teacher { get; set; }

        [DisplayName("Тип")]
        public LessionType LessionType { get; set; }

        [DisplayName("Кол-во")]
        public float Count { get; set; }
      
    }
    public class LessionData
    {
        public LessionData(string name)
        {
            Lession = name;
            Allias = name;
        }
        public LessionData() { }
        [DisplayName("Урок")]
        public string Lession { get; set; }
        [DisplayName("Название в системе")]
        public string Allias { get; set; }
        [DisplayName("Номер")]
        public int Number { get; set; }
        [DisplayName("Тип")]
        public string LessionType { get; set; }

    }
    public class FinalData
    {
       
        public FinalData() { }
        [DisplayName("Учитель")]
        public string Teacher { get; set; }
        [DisplayName("Программирование на языке C++")]
        public float g_cpp { get; set; }
    [DisplayName("C++_Start_Индивидуальное обучение")]
    public float  i_cpp{ get; set; }

    [DisplayName("Введение в олимпиадное программирование")]
    public float g_op{ get; set; }
    [DisplayName("OP_Start_Индивидуальное обучение")]
    public float i_op{ get; set; }

    [DisplayName("Программирование на языке Java")]
    public float g_java{ get; set; }
     [DisplayName("Java_Start_Индивидуальное обучение")]
    public float i_java{ get; set; }
    [DisplayName("Веб–разработка на HTML, CSS, JavaScript")]
    public float g_web{ get; set; }
     [DisplayName("Web_Start_Индивидуальное обучение")]
    public float i_web{ get; set; }
    [DisplayName("Python_Start_Группа")]
    public float g_pys{ get; set; }
     [DisplayName("Python_Start_Индивидуальное обучение")]
    public float i_pys{ get; set; }
    [DisplayName("Python_Middle_группа")]
    public float g_pym{ get; set; }
     [DisplayName("Python_Midlle_Индивидуальное обучение")]
    public float i_pym{ get; set; }
    [DisplayName("Python_PRO_Группа")]
    public float g_pyp{ get; set; }
     [DisplayName("Python_PRO_Индивидуальное обучение")]
    public float i_pyp{ get; set; }
    [DisplayName("ROBLOX")]
    public float g_ro{ get; set; }
     [DisplayName("Roblox_Start_Индивидуальное обучение")]
    public float i_ro{ get; set; }
    [DisplayName("Roblox_PRO")]
     public float g_rop { get; set; }
     [DisplayName("Roblox_PRO_Индивидуальное обучение")]
     public float i_rop { get; set; }
     [DisplayName("Scratch")]
        public float g_sc{ get; set; }
     [DisplayName("Scratch_Start_Индивидуальное обучение")]
    public float i_sc{ get; set; }
    [DisplayName("ОГЭ")]
    public float g_og{ get; set; }
     [DisplayName("ОГЭ_Индивидуальное обучение")]
    public float i_og{ get; set; }
    [DisplayName("Интенсив групповой")]
    public float g_int{ get; set; }
    [DisplayName("Интенсив инд")]
    public float i_int{ get; set; }
    [DisplayName("Неизвестно")]
    public float Unknown { get; set; }

    }
    public static class FinalDataStrings
    {
        //Костыль
     

        public static string g_cpp = "Программирование на языке C\u002B\u002B";
        public static string i_cpp = "C\u002B\u002B_Start_Индивидуальное обучение";
        public static string g_op = "Введение в олимпиадное программирование";
        public static string i_op = "OP_Start_Индивидуальное обучение";
        public static string g_java = "Программирование на языке Java";
        public static string i_java = "Java_Start_Индивидуальное обучение";
        public static string g_web = "Веб–разработка на HTML, CSS, JavaScript";
        public static string i_web = "Web_Start_Индивидуальное обучение";
        public static string g_pys = "Python_Start_Группа";
        public static string i_pys = "Python_Start_Индивидуальное обучение";
        public static string g_pym = "Python_Middle_группа";
        public static string i_pym = "Python_Middle_Индивидуальное обучение";
        public static string g_pyp = "Python_PRO_Группа";
        public static string i_pyp = "Python_PRO_Индивидуальное обучение";
        public static string g_ro = "ROBLOX";
        public static string i_ro = "Roblox_Start_Индивидуальное обучение";
        public static string g_rop = "Roblox_PRO";
        public static string i_rop = "Roblox_PRO_Индивидуальное обучение";
        public static string g_sc = "Scratch";
        public static string i_sc = "Scratch_Start_Индивидуальное обучение";
        public static string g_og = "ОГЭ";
        public static string i_og = "ОГЭ_Индивидуальное обучение";
        public static string g_int = "Интенсив";
        public static string i_int = "Интенсив";
        public static bool CheckAll(string check)
        {
            foreach (var field in typeof(FinalDataStrings).GetFields(BindingFlags.Static | BindingFlags.Public))
            {
                if (field.GetValue(null).ToString() == check) return true;

            }
            return false;
        }
    }



   


    public enum LessionType
    {
        Ind = 0,
        Group = 1
    }
    public class LessionsComparer : IEqualityComparer<LessionData>
    {
        public bool Equals(LessionData? x, LessionData? y)
        {
            if (Object.ReferenceEquals(x, null) || Object.ReferenceEquals(y, null))
                return false;

            return x.Lession == y.Lession;
        }

        public int GetHashCode([DisallowNull] LessionData obj)
        {
            //Check whether the object is null
            if (Object.ReferenceEquals(obj, null)) return 0;

            //Get hash code for the Name field if it is not null.
            int hashProductName = obj.Lession == null ? 0 : obj.Lession.GetHashCode();

            //Get hash code for the Code field.
            int hashProductCode = obj.Lession.GetHashCode();

            //Calculate the hash code for the product.
            return hashProductName ^ hashProductCode;
        }
    }
}
