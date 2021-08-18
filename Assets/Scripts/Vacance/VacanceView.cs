using UnityEngine;
public class VacanceView
{
    private Vacance[] _archerVacances;

    private int _count;
    private int _openVacance;

    public VacanceView(Vacance[] archerVacances)
    {
        _openVacance = 0;
        _archerVacances = archerVacances;
        _count = _archerVacances.Length - 1;
    }

    public int OpenVacance => _openVacance;

    public void ViewVacance()
    {
        if (_openVacance <= _count)
        {
            Debug.Log("Визуально вакансия открыта");
            _archerVacances[_openVacance].Open();
            _openVacance++;
        }
       
    }
    public void CloseVacance()
    {
        if (_openVacance > 0)
        {
            _archerVacances[_openVacance].Close();
            _openVacance--;
        }
    }

}
