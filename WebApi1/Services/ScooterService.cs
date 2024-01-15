using WebApi1.Model;

namespace WebApi1.Services;

public class ScooterService
{
    
    //<scooterId, isHired>
    private Dictionary<int, bool> scooterIds = new Dictionary<int, bool> { 
            {1, false},
            {2, false},
            {3, false},
            {4, false}
    };
    
    public void HireScooter(ScooterUser scooterUser)
    {
        if (scooterUser.AssignedScooterId == null)
        {
            var firstAvailableScooter = scooterIds.FirstOrDefault(s => !s.Value);
            
            scooterUser.AssignedScooterId = firstAvailableScooter.Key;

            scooterIds[firstAvailableScooter.Key] = true;
        }
        else
        {
            throw (new Exception("Already has a scooter assigned"));
        }
    }
}