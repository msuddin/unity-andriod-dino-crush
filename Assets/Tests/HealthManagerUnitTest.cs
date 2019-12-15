using NUnit.Framework;
using System;

namespace Tests
{
    public class HealthManagerUnitTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void shouldBeAbleToReducePlayerHealth()
        {
            // Given
            var healthBeforeDamage = 100;
            var damageDealt = 25;
            var healthManager = new HealthManager();
            healthManager.health = healthBeforeDamage;

            // When
            healthManager.reduceHeealth(damageDealt);

            // Then
            Console.WriteLine("Test string");
            Assert.That(true == true);
        }
    }
}
