using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class DeathTests
{
    
    [UnityTest]
    public IEnumerator DeathTestsWithEnumeratorPasses()
    {
        var gameObject = new GameObject();
        var death = gameObject.AddComponent<Death>();
        int currentLivesCount = death.getLivesCount();
        death.addLivesCount();
        yield return new WaitForSeconds(1f); //тут что-то делается в игре
        Assert.AreEqual(currentLivesCount++, death.getLivesCount());
    }
}
