using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schiphol.Models
{

	public class AircraftTypeList
	{
		public List<AircraftType> AircraftTypes { get; set; }
	}

	public class AircraftType
	{
		public string IATAMain { get; set; }
		public string IATASub { get; set; }
		public string LongDescription { get; set; }
		public string ShortDescription { get; set; }
	}

	public class Airline
	{
		public string IATA { get; set; }
		public string Icao { get; set; }
		public string Nvls { get; set; }
		public string PublicName { get; set; }
	}

	public class Destination
	{
		public string City { get; set; }
		public string Country { get; set; }
		public string IATA { get; set; }
		public string PublicName_NL { get; set; }
		public string PublicName_EN { get; set; }
	}

	public class FlightList
	{
		public List<Flight> Flights { get; set; }
	}

	public class Flight
	{
		public string LastUpdatedAt { get; set; }
		public DateTime? dtLastUpdatedAt
		{
			get
			{
				if (string.IsNullOrEmpty(this.LastUpdatedAt))
					return null;
				else
					return DateTime.Parse(this.LastUpdatedAt);
			}
		}
		public string ActualLandingTime { get; set; }
		public DateTime? dtActualLandingTime
		{
			get
			{
				if (string.IsNullOrEmpty(this.ActualLandingTime))
					return null;
				else
					return DateTime.Parse(this.ActualLandingTime);
			}
		}
		public string ActualOffBlockTime { get; set; }
		public DateTime? dtActualOffBlockTime
		{
			get
			{
				if (string.IsNullOrEmpty(this.ActualOffBlockTime))
					return null;
				else
					return DateTime.Parse(this.ActualOffBlockTime);
			}
		}
		public string AircraftRegistration { get; set; }
		public AircraftType? AircraftType { get; set; }
		public BaggageClaimType? BaggageClaim { get; set; }
		public CheckinAllocationsType? CheckinAllocations { get; set; }
		public CodesharesType? Codeshares { get; set; }
		public string EstimatedLandingTime { get; set; }
		public DateTime? dtEstimatedLandingTime
		{
			get
			{
				if (string.IsNullOrEmpty(this.EstimatedLandingTime))
					return null;
				else
					return DateTime.Parse(this.EstimatedLandingTime);
			}
		}
		public string ExpectedTimeBoarding { get; set; }
		public DateTime? dtExpectedTimeBoarding
		{
			get
			{
				if (string.IsNullOrEmpty(this.ExpectedTimeBoarding))
					return null;
				else
					return DateTime.Parse(this.ExpectedTimeBoarding);
			}
		}
		public string ExpectedTimeGateClosing { get; set; }
		public DateTime? dtExpectedTimeGateClosing
		{
			get
			{
				if (string.IsNullOrEmpty(this.ExpectedTimeGateClosing))
					return null;
				else
					return DateTime.Parse(this.ExpectedTimeGateClosing);
			}
		}
		public string ExpectedTimeGateOpen { get; set; }
		public DateTime? dtExpectedTimeGateOpen
		{
			get
			{
				if (string.IsNullOrEmpty(this.ExpectedTimeGateOpen))
					return null;
				else
					return DateTime.Parse(this.ExpectedTimeGateOpen);
			}
		}
		public string ExpectedTimeOnBelt { get; set; }
		public DateTime? dtExpectedTimeOnBelt
		{
			get
			{
				if (string.IsNullOrEmpty(this.ExpectedTimeOnBelt))
					return null;
				else
					return DateTime.Parse(this.ExpectedTimeOnBelt);
			}
		}
		public string ExpectedSecurityFilter { get; set; }
		public string FlightDirection { get; set; }
		public string FlightName { get; set; }
		public int? FlightNumber { get; set; }
		public string Gate { get; set; }
		public string Pier { get; set; }
		public string Id { get; set; }
		public string MainFlight { get; set; }
		public string PrefixIATA { get; set; }
		public string PrefixICAO { get; set; }
		public int? AirlineCode { get; set; }
		public string PublicEstimatedOffBlockTime { get; set; }
		public DateTime? dtPublicEstimatedOffBlockTime
		{
			get
			{
				if (string.IsNullOrEmpty(this.PublicEstimatedOffBlockTime))
					return null;
				else
					return DateTime.Parse(this.PublicEstimatedOffBlockTime);
			}
		}
		public PublicFlightStateType? PublicFlightState { get; set; }
		public RouteType? Route { get; set; }
		public string ScheduleDateTime { get; set; }
		public DateTime? dtScheduleDateTime
		{
			get
			{
				if (string.IsNullOrEmpty(this.ScheduleDateTime))
					return null;
				else
					return DateTime.Parse(this.ScheduleDateTime);
			}
		}
		public string ScheduleDate { get; set; }
		public DateTime? dtScheduleDate
		{
			get
			{
				if (string.IsNullOrEmpty(this.ScheduleDate))
					return null;
				else
					return DateTime.Parse(this.ScheduleDate);
			}
		}
		public string ScheduleTime { get; set; }
		public string ServiceType { get; set; }
		public string Terminal { get; set; }
		public TransferPositionsType? TransferPositions { get; set; }
		public string SchemaVersion { get; set; }
	}

	public class BaggageClaimType
	{
		public List<string> Belts { get; set; }
	}

	public class CheckinAllocationsType
	{
		public List<CheckinAllocationType> CheckinAllocations { get; set; }
		public RemarksType? Remarks { get; set; }
	}

	public class CheckinAllocationType
	{
		public string EndTime { get; set; }
		public RowsType? Rows { get; set; }
		public string StartTime { get; set; }
	}

	public class TransferPositionsType
	{
		public List<int> TransferPositions { get; set; }
	}

	public class RemarksType
	{
		public List<string> Remarks { get; set; }
	}

	public class RowsType
	{
		List<RowType> Rows { get; set; }
	}

	public class RowType
	{
		public string Position { get; set; }
		public DeskType? Desks { get; set; }
	}

	public class DesksType
	{
		public List<DeskType> Desks { get; set; }
	}

	public class DeskType
	{
		public CheckinClassType? CheckinClass { get; set; }
		public int? Position { get; set; }
	}

	public class CheckinClassType
	{
		public string Code { get; set; }
		public string Description { get; set; }
	}

	public class RouteType
	{
		public List<string> Destinations { get; set; }
		public string EU { get; set; }
		public bool Visa { get; set; }
	}

	public class PublicFlightStateType
	{
		public List<string> FlightStates { get; set; }
	}

	public class CodesharesType
	{
		public List<string> Codeshares { get; set; }
	}
}
