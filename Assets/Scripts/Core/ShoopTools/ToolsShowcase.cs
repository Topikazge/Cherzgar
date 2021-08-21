using UnityEngine;
public class ToolsShowcase
{
    private ShowcaseTools[] _archerVacances;

    private int _count;
    private int _toolsAvailable;

    public ToolsShowcase(ShowcaseTools[] archerVacances)
    {
        _toolsAvailable = 0;
        _archerVacances = archerVacances;
        _count = _archerVacances.Length - 1;
    }

    public int ToolsAvailable => _toolsAvailable;

    public void ShowTool()
    {
        if (_toolsAvailable <= _count)
        {
            _archerVacances[_toolsAvailable].Show();
            _toolsAvailable++;
        }
       
    }
    public void HideTool()
    {
        if (_toolsAvailable > 0)
        {
            _archerVacances[_toolsAvailable].Hide();
            _toolsAvailable--;
        }
    }

}
