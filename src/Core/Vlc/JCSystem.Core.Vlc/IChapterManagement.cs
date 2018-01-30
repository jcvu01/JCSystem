namespace JCSystem.Core.Vlc
{
    public interface IChapterManagement
    {
        int Count { get; }
        void Previous();
        void Next();
        int Current { get; set; }
    }
}
