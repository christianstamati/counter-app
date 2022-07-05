using System.Collections;
using CounterApp.Main;
using JetBrains.Annotations;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests.PlayMode
{
    public class CounterBehaviourTests
    {
        [UnityTest]
        [CanBeNull]
        public IEnumerator OnAdd_WhenCalled_ShouldAddOneUnitToCountVariable()
        {
            // Arrange
            var counter = new GameObject("Counter").AddComponent<CounterBehaviour>();
            
            // Act
            counter.OnAdd();
            
            // Assert
            Assert.That(counter.count, Is.EqualTo(1));
            yield return null;
        }
        
        [UnityTest]
        [CanBeNull]
        public IEnumerator OnAdd_WhenCalled_ShouldInvokeOnCountAddedEvent()
        {
            // Arrange
            var counter = new GameObject("Counter").AddComponent<CounterBehaviour>();

            var invoked = false;
            counter.onCountUpdated.AddListener(count => { invoked = true; });
            
            // Act
            counter.OnAdd();
            
            // Assert
            Assert.True(invoked);
            yield return null;
        }
    }
}
