using System;

class RemoteControlCar {

    private int _distanceDriven;
    private int _currentBattery = 100;
    
    public static RemoteControlCar Buy() {

        var newCar = new RemoteControlCar();

        return newCar;
    }

    public string DistanceDisplay() {

        return $"Driven {_distanceDriven} meters";
    }

    public string BatteryDisplay() {

        if (_currentBattery == 0) {

            return "Battery empty";
        }

        return $"Battery at {_currentBattery}%";
    }

    public void Drive() {

        if (_currentBattery > 0) {

            _distanceDriven += 20;
            _currentBattery -= 1;
        }
    }
}
