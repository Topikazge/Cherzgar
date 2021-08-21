using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IFreeTool
{
    bool TryGetTool();
    void GetTool(UnitBase inhabitantBase); 
}
