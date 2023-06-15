import { CrudInterface } from "./CrudInterface";
import { HttpClient, HttpHeaders, HttpResponse, HttpStatusCode } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { Producator } from "src/Models/Producator";
import { ProducatorDTO } from "src/Models/Producatordto";

@Injectable()
export class ProducatorCrud implements CrudInterface<Producator,number>{

  constructor(private httpClient: HttpClient) {
   }
    delete(id: number): Observable<any> {
        return this.httpClient.delete<HttpResponse<any>>(`https://localhost:7145/api/producator/${id}`) // log status code
    }
    get(id: number): Observable<Producator> {
        return this.httpClient.get<Producator>(`https://localhost:7145/api/producator/${id}`)
    }
    getAll(): Observable<Producator[]> {
        let reuslt:Producator[]=[]
        return this.httpClient.get<Producator[]>("https://localhost:7145/api/producator")
    }
    create(entity: Producator): Observable<any> {
        return this.httpClient.post<HttpResponse<any>>(`https://localhost:7145/api/producator`,entity)
    }
    update(entity: Producator, id: number): Observable<any> {
        let headers = new HttpHeaders({
            'Content-Type': 'application/json'
          });
        return this.httpClient.put<HttpResponse<any>>(`https://localhost:7145/api/producator/${id}`,entity,{headers: headers}) // log status code
    }

}