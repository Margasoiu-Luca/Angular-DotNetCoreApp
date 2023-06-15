import { Producator } from 'src/Models/Producator';
import { ProducatorDTO } from 'src/Models/Producatordto';
import { ProdusDTO } from 'src/Models/Produs';
// Create and export the mapper
export class MapperService {
    mapProducatorToProducatorDTO(producator: Producator): ProducatorDTO {
      const producatorDTO = new ProducatorDTO();
      producatorDTO.producatorId = producator.producatorId;
      producatorDTO.producatorIdCt = producator.producatorIdCt;
      producatorDTO.dataInceput = producator.dataInceput;
      producatorDTO.dataSfarsit = producator.dataSfarsit;
      producatorDTO.nume = producator.nume;
      producatorDTO.adresa = producator.adresa;
      producatorDTO.mmId = producator.mmId;
  
      return producatorDTO;
    }
  
    mapProducatorDTOToProducator(producatorDTO: ProducatorDTO): Producator {
      const producator = new Producator();
      producator.producatorId = producatorDTO.producatorId!;
      producator.producatorIdCt = producatorDTO.producatorIdCt!;
      producator.dataInceput = producatorDTO.dataInceput!;
      producator.dataSfarsit = producatorDTO.dataSfarsit!;
      producator.nume = producatorDTO.nume;
      producator.adresa = producatorDTO.adresa;
      producator.mmId = producatorDTO.mmId!;
  
      return producator;
    }
  }