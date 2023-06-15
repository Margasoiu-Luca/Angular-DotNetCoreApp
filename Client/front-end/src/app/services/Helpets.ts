abstract class Helpers{
    public static  GetStatusString(statusInt:number):string{
        switch(statusInt){
            case 0:
                return "Activ";
                break;
            case 1:
                return "Inactiv";
                break;
            default:
                return "Sters";
                break;
        }
    }
}
