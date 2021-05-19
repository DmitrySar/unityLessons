using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class DeathTest
{

    [Test]
    public void getLivesCountAfterAddLife()
    {
        Death death = new Death();
        int currentLivesCount = death.getLivesCount();
        death.addLivesCount();
        Assert.AreEqual(currentLivesCount++, death.getLivesCount());
    }

}
