using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorSolowek.Contracts
{
    [ServiceContract]
    public interface IFileGenerator
    {
        [OperationContract]
        void SetMinFret(int _minFret);
        [OperationContract]
        void SetMaxFret(int _maxFret);
        [OperationContract]
        bool WrongFrets();
        [OperationContract]
        void CreateFile(IList<string[]> fretboard);          // Tworzy plik teksowy z wylosowana tabulatura
        [OperationContract]
        void UpdateFile(string[] linesArray, ref IList<string[]> fretboard);
        [OperationContract]
        Tuple<int, int> GetLastNote(string[] linesArray);
        [OperationContract]
        string[] GetArrayFromFile();
        [OperationContract]
        IList<Tuple<int, int>> PickNotes(IList<int[]> scaleFrets, string[] linesArray = null);         // Tworzy tablice ze wspólrzednymi wylosowanych dzwieków ze skali
        [OperationContract]
        IList<string[]> CreateEmptyTab();            // Tworzy tablice wypelniona "-"
        [OperationContract]
        void InsertPickedNotes(ref IList<string[]> fretboard, IList<Tuple<int,int>> pickedNotes, IList<int[]> scaleFrets);                    // Zamienia odpowiednie miejsca w tablicy wylosowanymi dzwiekami ze skali
        [OperationContract]
        void SetNumberOfIterations(int noi);
        [OperationContract]
        string GetPath();
        [OperationContract]
        void IncrementNumberOfIterations();
        #region SKALE
        [OperationContract]
        IList<int[]> GetDMajorFrets();
        [OperationContract]
        IList<int[]> GetCMajorFrets();
        [OperationContract]
        IList<int[]> GetABluesFrets();

        #endregion
    }
}
