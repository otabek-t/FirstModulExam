using FirstModulExam.Model;

namespace FirstModulExam.Service;

public class HouseService
{
    private List<HouseModel> houses;
    public HouseService(HouseModel houses)
    {
        houses = new HouseModel();
    }

    public HouseModel GetById(Guid id)
    {
        var houseId = Guid.NewGuid();
        foreach (var house in houses)
        {
            if (house.Id == id)
            {
                return house;
            }
        }
        return null;

    }

    public bool AddHouse(Guid houseID)
    {
        var house = GetById(houseID);
        if (house == null)
        {
            return false;
        }
        houses.Add(house);
        return true;

    }

    public bool RemoveHouse(Guid removeHouseID)
    {
        var house = GetById(removeHouseID);

        if (house == null)
        {
            return false;
        }
        houses.Remove(house);
        return true;
    }
    public bool UpdateHouse(Guid houseID)
    {
        var house = GetById(houseID);
        if (house == null)
        {
            return false;
        }
        var index = houses.IndexOf(house);
        houses[index] = house;
        return true;
    }
    public List<HouseModel> GetAll()
    {
        return houses;
    }

}
