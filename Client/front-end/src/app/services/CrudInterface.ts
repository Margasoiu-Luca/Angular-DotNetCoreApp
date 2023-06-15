import { HttpResponse, HttpStatusCode } from "@angular/common/http";
import { Observable } from "rxjs";

export abstract class CrudInterface<T,Id> {
    abstract get(id:Id): Observable<T>;
    abstract getAll():Observable<Array<T>>
    abstract create(entity:T):Observable<any>;
    abstract update(entity:T,id:Id):Observable<any>;
    abstract delete(id:Id):Observable<any>
}
export abstract class IMyService {
    abstract get(): void;
  }